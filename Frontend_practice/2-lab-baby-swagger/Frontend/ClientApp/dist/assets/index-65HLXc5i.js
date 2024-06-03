(function(){const e=document.createElement("link").relList;if(e&&e.supports&&e.supports("modulepreload"))return;for(const t of document.querySelectorAll('link[rel="modulepreload"]'))u(t);new MutationObserver(t=>{for(const s of t)if(s.type==="childList")for(const i of s.addedNodes)i.tagName==="LINK"&&i.rel==="modulepreload"&&u(i)}).observe(document,{childList:!0,subtree:!0});function o(t){const s={};return t.integrity&&(s.integrity=t.integrity),t.referrerPolicy&&(s.referrerPolicy=t.referrerPolicy),t.crossOrigin==="use-credentials"?s.credentials="include":t.crossOrigin==="anonymous"?s.credentials="omit":s.credentials="same-origin",s}function u(t){if(t.ep)return;t.ep=!0;const s=o(t);fetch(t.href,s)}})();const a="data:image/svg+xml,%3csvg%20xmlns='http://www.w3.org/2000/svg'%20width='20'%20height='20'%20viewBox='0%200%2020%2020'%3e%3cpath%20d='M%2017.418%2014.908%20C%2017.69%2015.176%2018.127%2015.176%2018.397%2014.908%20C%2018.667%2014.64%2018.668%2014.207%2018.397%2013.939%20L%2010.489%206.109%20C%2010.219%205.841%209.782%205.841%209.51%206.109%20L%201.602%2013.939%20C%201.332%2014.207%201.332%2014.64%201.602%2014.908%20C%201.873%2015.176%202.311%2015.176%202.581%2014.908%20L%2010%207.767%20L%2017.418%2014.908%20Z'%3e%3c/path%3e%3c/svg%3e",m=r=>{const e=document.createElement("div");return e.innerHTML=typeof r=="string"?r:r.join(""),e.firstElementChild},l=()=>`
  <div>
    <div class="route route-get">
      <div class="route-header">
        <button class="route-summary">
          <div class="route-summary-method">GET</div>
          <span class="route-summary-path">/Users</span>
          <div class="route-summary-arrow"><img class="arrow" src=${a} /></div>
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
          <div class="route-summary-arrow"><img class="arrow" src=${a} /></div>
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
          <div class="route-summary-arrow"><img class="arrow" src=${a} /></div>
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
          <div class="route-summary-arrow"><img class="arrow" src=${a} /></div>
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
          <div class="route-summary-arrow"><img class="arrow" src=${a} /></div>
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
          <div class="route-summary-arrow"><img class="arrow" src=${a} /></div>
        </button>
      </div>
      <form class="form" style="display: none;">
        <input type="text" name="userId" placeholder="User ID">
        <button type="submit">Submit</button>
      </form>
    </div>
  </div>`,n=r=>{const e=r.querySelector(".form"),o=r.querySelector(".route-summary-arrow .arrow");e&&(e.style.display=e.style.display==="none"?"block":"none"),o&&(o.style.transform=(e==null?void 0:e.style.display)==="none"?"rotate(180deg)":"rotate(0deg)")},c=()=>{const r=document.querySelector("#app"),e=m(l());r&&e&&r.append(e),document.querySelectorAll(".route-summary").forEach(o=>{o.addEventListener("click",()=>{const u=o.closest(".route");u&&n(u)})})};c();
