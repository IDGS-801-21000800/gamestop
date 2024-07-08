import { NgModule } from '@angular/core';
import { CommonModule, NgFor, NgIf } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { BannerComponent } from './banner/banner.component';
import { BuscarComponent } from './buscar/buscar.component';
import { ContactoComponent } from './contacto/contacto.component';

@NgModule({
  declarations: [BannerComponent, BuscarComponent, ContactoComponent],
  imports: [CommonModule, HttpClientModule, FormsModule, NgFor, NgIf],
  exports: [BannerComponent, BuscarComponent, ContactoComponent]
})
export class FeaturesModule { }
