using System.IO;
using Accommodations.Commands;
using Accommodations.Dto;

namespace Accommodations;

public static class AccommodationsProcessor
{
    private static BookingService _bookingService = new();
    private static Dictionary<int, ICommand> _executedCommands = new();
    private static int _commandIndex = 0;

    public static void Run()
    {
        string command, exit = "exit";

        Console.WriteLine( "Booking Command Line Interface" );
        Console.WriteLine( "Commands:" );
        Console.WriteLine( "'book <UserId> <Category> <StartDate> <EndDate> <Currency>' - to book a room" );
        Console.WriteLine( "'cancel <BookingId>' - to cancel a booking" );
        Console.WriteLine( "'undo' - to undo the last command" );
        Console.WriteLine( "'find <BookingId>' - to find a booking by ID" );
        Console.WriteLine( "'search <StartDate> <EndDate> <CategoryName>' - to search bookings" );
        Console.WriteLine( "'exit' - to exit the application" );

        while ( ( command = Console.ReadLine() ) != "exit" )
        {
            try
            {
                ProcessCommand( command );
            }
            catch ( ArgumentException ex )
            {
                Console.WriteLine( $"Error: {ex.Message}" );
            }
            catch ( Exception ex )
            {
                Console.WriteLine( ex.Message );
            }
        }
    }

    private static void ProcessCommand( string command )
    {
        string[] commandParts = command.Split( ' ' );
        string commandName = commandParts[ 0 ];

        switch ( commandName )
        {
            case "book":
                ProcessBookCommand( commandParts );
                break;
            case "cancel":
                ProcessCancelCommand( commandParts );
                break;
            case "undo":
                UndoLastCommand();
                break;
            case "find":
                ProcessFindCommand( commandParts );
                break;
            case "search":
                ProcessSearchCommand( commandParts );
                break;
            default:
                Console.WriteLine( "Unknown command." );
                break;
        }
    }

    private static void ProcessBookCommand( string[] commandParts )
    {
        if ( commandParts.Length != 6 )
        {
            Console.WriteLine( "Invalid number of arguments for booking." );
            return;
        }

        string strUserId = commandParts[ 1 ];
        string category = commandParts[ 2 ];
        string strStartDate = commandParts[ 3 ];
        string strEndDate = commandParts[ 4 ];
        string strCurrency = commandParts[ 5 ];

        if ( !int.TryParse( strUserId, out int userId ) )
        {
            throw new ArgumentException( "Invalid Id format" );
        }

        if ( !DateTime.TryParse( strStartDate, out DateTime startDate ) )
        {
            throw new ArgumentException( $"Invalid start date format: {strStartDate}, valid format: mm/dd/yyyy" );
        }

        if ( !DateTime.TryParse( strEndDate, out DateTime endDate ) )
        {
            throw new ArgumentException( $"Invalid start date format: {strStartDate}, valid format: mm/dd/yyyy" );
        }

        string validCurrencies = string.Join( ", ", Enum.GetNames( typeof( CurrencyDto ) ) );

        if ( !Enum.TryParse( strCurrency, true, out CurrencyDto currency ) )
        {
            throw new ArgumentException( $"Invalid currency: {strCurrency}. Valid options are: {validCurrencies}." );
        }

        BookingDto bookingDto = new()
        {
            UserId = userId,
            Category = category,
            StartDate = startDate,
            EndDate = endDate,
            Currency = currency
        };

        BookCommand bookCommand = new( _bookingService, bookingDto );
        bookCommand.Execute();
        _executedCommands.Add( ++_commandIndex, bookCommand );
        Console.WriteLine( "Booking command run is successful." );
    }


    private static void ProcessCancelCommand( string[] commandParts )
    {
        if ( commandParts.Length != 2 )
        {
            throw new ArgumentException( "Invalid number of arguments for canceling." );
        }

        if ( !Guid.TryParse( commandParts[ 1 ], out Guid bookingId ) )
        {
            throw new ArgumentException( "Invalid booking ID format." );
        }

        CancelBookingCommand cancelCommand = new( _bookingService, bookingId );
        cancelCommand.Execute();
        _executedCommands.Add( ++_commandIndex, cancelCommand );
        Console.WriteLine( "Cancellation command run is successful." );
    }

    private static void UndoLastCommand()
    {
        if ( _executedCommands.Count == 0 )
        {
            throw new ArgumentException( "No commands to undo." );
        }

        _executedCommands[ _commandIndex ].Undo();
        _executedCommands.Remove( _commandIndex );
        _commandIndex--;
        Console.WriteLine( "Last command undone." );
    }

    private static void ProcessFindCommand( string[] parts )
    {
        if ( parts.Length != 2 )
        {
            throw new ArgumentException( "Invalid arguments for 'find'. Expected format: 'find <BookingId>'" );
        }
        if ( !Guid.TryParse( parts[ 1 ], out Guid id ) )
        {
            throw new ArgumentException( "Invalid booking ID format." );
        }

        FindBookingByIdCommand findCommand = new( _bookingService, id );
        findCommand.Execute();
    }

    private static void ProcessSearchCommand( string[] parts )
    {
        if ( parts.Length != 4 )
        {
            throw new ArgumentException( "Invalid arguments for 'search'. Expected format: 'search <StartDate> <EndDate> <CategoryName>'" );
        }
        if ( !DateTime.TryParse( parts[ 1 ], out DateTime startDate ) )
        {
            throw new ArgumentException( $"Invalid start date format: {parts[ 1 ]}" );
        }
        if ( !DateTime.TryParse( parts[ 2 ], out DateTime endDate ) )
        {
            throw new ArgumentException( $"Invalid end date format: {parts[ 2 ]}" );
        }

        string categoryName = parts[ 3 ];
        SearchBookingsCommand searchCommand = new( _bookingService, startDate, endDate, categoryName );
        searchCommand.Execute();
    }
}