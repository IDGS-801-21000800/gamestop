import { Component } from '@angular/core';
import { JuegoService } from '../juego.service';
import { IJuego } from '../../interfaces/ijuego';
import { Observable } from 'rxjs';
import { NgFor, NgIf } from '@angular/common';

@Component({
  selector: 'app-banner',
  templateUrl: './banner.component.html',
  styleUrl: './banner.component.css',
})
export class BannerComponent {
  juegos: IJuego[] = [];
  constructor(private juegoServ: JuegoService) {
    this.juegos = [];
    juegoServ.getList().subscribe((juegos: IJuego[]) => {
      this.juegos = juegos;
    });
  }

}
