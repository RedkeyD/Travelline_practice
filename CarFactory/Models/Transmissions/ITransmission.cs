using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Models.Transmissions;
public interface ITransmission
{
    public int NumberOfGears { get; }
    public string Name { get; } 
}