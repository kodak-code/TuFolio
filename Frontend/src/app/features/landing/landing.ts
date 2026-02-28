import { Component, OnDestroy, OnInit, Renderer2, Inject } from '@angular/core';
import { DOCUMENT, CommonModule } from '@angular/common';
import { HeaderComponent } from "../../shared/components/header/header.component";
import { FooterComponent } from "../../shared/components/footer/footer.component";

@Component({
  selector: 'app-landing',
  standalone: true,
  imports: [CommonModule, HeaderComponent, FooterComponent],
  templateUrl: './landing.html',
  styleUrls: ['./landing.css'],
})
export class Landing implements OnInit, OnDestroy {

  constructor(
    private renderer: Renderer2,
    @Inject(DOCUMENT) private document: Document
  ) { }

  ngOnInit(): void { // aplicar estilos desde style.css
    this.renderer.addClass(this.document.body, 'landing-bg');
  }

  ngOnDestroy(): void { // limpiar body
    this.renderer.removeClass(this.document.body, 'landing-bg');
  }
}