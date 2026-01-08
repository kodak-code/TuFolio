import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { SharedModule } from '../../Reutilizable/shared/shared-module';
import { RouterModule } from '@angular/router';

@Component({
  selector: 'app-layout.component',
  imports: [CommonModule, ReactiveFormsModule, SharedModule, RouterModule],
  templateUrl: './layout.component.html',
  styleUrl: './layout.component.css',
})
export class LayoutComponent {

}
