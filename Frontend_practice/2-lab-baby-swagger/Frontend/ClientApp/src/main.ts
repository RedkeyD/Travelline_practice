import arrowIcon from "./icon-arrow-up.svg";
import "./style.css";

const createHtmlNode = (htmlString: string | string[]) => {
  const placeholder = document.createElement("div");
  placeholder.innerHTML = typeof htmlString === `string` ? htmlString : htmlString.join(``);

  return placeholder.firstElementChild;
};

const createHtml = () => {
  return `
  <div>
    <div class="route route-get">
      <div class="route-header">
        <button class="route-summary">
          <div class="route-summary-method">GET</div>
          <span class="route-summary-path">/Users</span>
          <div class="route-summary-arrow"><img class="arrow" src=${arrowIcon} /></div>
        </button>
      </div>
      <form class="form" style="display: none;">
        <input type="text" name="userId" placeholder="User ID">
        <button type="submit">Submit</button>
      </form>
    </div>
    <div class="route route-post">
      <div class="route-header">
        <button class="route-summary">
          <div class="route-summary-method">POST</div>
          <span class="route-summary-path">/Users</span>
          <div class="route-summary-arrow"><img class="arrow" src=${arrowIcon} /></div>
        </button>
      </div>
      <form class="form" style="display: none;">
        <input type="text" name="userName" placeholder="User Name">
        <input type="email" name="userEmail" placeholder="User Email">
        <button type="submit">Submit</button>
      </form>
    </div>
    <div class="route route-get">
      <div class="route-header">
        <button class="route-summary">
          <div class="route-summary-method">GET</div>
          <span class="route-summary-path">/Users/{id}</span>
          <div class="route-summary-arrow"><img class="arrow" src=${arrowIcon} /></div>
        </button>
      </div>
      <form class="form" style="display: none;">
        <input type="text" name="userId" placeholder="User ID">
        <button type="submit">Submit</button>
      </form>
    </div>
    <div class="route route-put">
      <div class="route-header">
        <button class="route-summary">
          <div class="route-summary-method">PUT</div>
          <span class="route-summary-path">/Users/{id}</span>
          <div class="route-summary-arrow"><img class="arrow" src=${arrowIcon} /></div>
        </button>
      </div>
      <form class="form" style="display: none;">
        <input type="text" name="userId" placeholder="User ID">
        <input type="text" name="userName" placeholder="User Name">
        <button type="submit">Submit</button>
      </form>
    </div>
    <div class="route route-delete">
      <div class="route-header">
        <button class="route-summary">
          <div class="route-summary-method">DELETE</div>
          <span class="route-summary-path">/Users/{id}</span>
          <div class="route-summary-arrow"><img class="arrow" src=${arrowIcon} /></div>
        </button>
      </div>
      <form class="form" style="display: none;">
        <input type="text" name="userId" placeholder="User ID">
        <button type="submit">Submit</button>
      </form>
    </div>
    <div class="route route-get">
      <div class="route-header">
        <button class="route-summary">
          <div class="route-summary-method">GET</div>
          <span class="route-summary-path">/Users/get-by-email/{email}</span>
          <div class="route-summary-arrow"><img class="arrow" src=${arrowIcon} /></div>
        </button>
      </div>
      <form class="form" style="display: none;">
        <input type="text" name="userId" placeholder="User ID">
        <button type="submit">Submit</button>
      </form>
    </div>
  </div>`;
};

const toggleForm = (routeBlock: HTMLElement): void => {
  const form = routeBlock.querySelector<HTMLFormElement>('.form');
  const arrow = routeBlock.querySelector<HTMLImageElement>('.route-summary-arrow .arrow');
  if (form) {
    form.style.display = form.style.display === 'none' ? 'block' : 'none';
  }
  if (arrow) {
    arrow.style.transform = form?.style.display === 'none' ? 'rotate(180deg)' : 'rotate(0deg)';
  }
};

const initialize = (): void => {
  const appDiv = document.querySelector<HTMLDivElement>("#app");
  const node = createHtmlNode(createHtml());
  if (appDiv && node) {
    appDiv.append(node);
  }

  document.querySelectorAll<HTMLButtonElement>('.route-summary').forEach((button) => {
    button.addEventListener('click', () => {
      const routeBlock = button.closest<HTMLElement>('.route');
      if (routeBlock) {
        toggleForm(routeBlock);
      }
    });
  });
};

initialize();