import { Routes } from '@angular/router';
import { BannerComponent } from './features/banner/banner.component';
import { ContactoComponent } from './features/contacto/contacto.component';
import { BuscarComponent } from './features/buscar/buscar.component';


export const routes: Routes = [
    { path: '', component: BannerComponent },
    { path: 'buscar', component: BuscarComponent },
    { path: 'contacto', component: ContactoComponent }];
