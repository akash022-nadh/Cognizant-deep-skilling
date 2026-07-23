import { Routes } from '@angular/router';
import { ReportsComponent } from './reports.component';

// This whole route tree is loaded on-demand (see loadChildren in app.routes.ts) -
// none of this code is included in the initial bundle.
export const REPORTS_ROUTES: Routes = [
  {
    path: '',
    component: ReportsComponent,
    children: [
      // Nested route example: /reports/summary
      { path: 'summary', component: ReportsComponent }
    ]
  }
];
