import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { User } from '../../services/data.service';
import { CanComponentDeactivate } from '../../guards/unsaved-changes.guard';

@Component({
  selector: 'app-user-detail',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './user-detail.component.html'
})
export class UserDetailComponent implements OnInit, CanComponentDeactivate {
  user!: User;
  referrer = '';
  editedName = '';

  constructor(private route: ActivatedRoute) {}

  ngOnInit(): void {
    // Data pre-fetched by userResolver - already available synchronously via route data.
    this.user = this.route.snapshot.data['user'];
    this.editedName = this.user.name;

    // Query param, e.g. ?ref=home-list
    this.referrer = this.route.snapshot.queryParamMap.get('ref') ?? '';
  }

  hasUnsavedChanges(): boolean {
    return this.editedName !== this.user.name;
  }
}
