import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { SharedModule } from '../../shared/shared-module';
import { RouterModule } from '@angular/router';

@Component({
  selector: 'app-admin.component',
  imports: [CommonModule, ReactiveFormsModule, SharedModule, RouterModule],
  templateUrl: './admin.component.html',
  styleUrl: './admin.component.css',
})
export class AdminComponent {

}
