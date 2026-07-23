import { Component } from '@angular/core';

@Component({
  selector: 'app-reports',
  standalone: true,
  template: `
    <h2>Reports</h2>
    <p>This component's code (and its route) was only downloaded when you navigated here - lazy loading in action.</p>
  `
})
export class ReportsComponent {}
