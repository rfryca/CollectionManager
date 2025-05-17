import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { MenuComponent } from './components/menu/menu.component';
import { TopBarComponent } from './components/top-bar/top-bar.component';
import { Tooltip, initTWE } from 'tw-elements';
import { Title } from '@angular/platform-browser';  


@Component({
  selector: 'app-root',
  imports: [RouterOutlet, MenuComponent, TopBarComponent],
  // templateUrl: './app.component.html',
  template: `
    <app-menu></app-menu>
    <app-top-bar></app-top-bar>
    <div class="text-center text-3xl font-bold text-blue-600">
      {{tailwindText}}
    </div>
  
    <p>
      Hover the link to see the
      <a i18n
        href="#"
        class="text-primary dark:text-primary-400"
        data-twe-toggle="tooltip"
        i18n-title
        title="It is tooltip text" 
        >tooltip</a
      >
    </p>
    <router-outlet />
  `,
  styles: [],
  // styleUrls: ['./app.component.css'],
})
export class AppComponent {
  ngOnInit() {
    initTWE({ Tooltip }, { allowReinits: true });
  }

  title = 'CollectionManager.Angular';
  tailwindText=$localize`'Hello Tailwind in Angular!'`;
  tooltipText=$localize`'This is a tooltip!'`;

  constructor(private titleService: Title) {
    this.titleService.setTitle($localize`${this.title}`);
  }
}

