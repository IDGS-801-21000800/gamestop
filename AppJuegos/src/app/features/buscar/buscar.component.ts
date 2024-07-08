import { Component } from '@angular/core';
import { IJuego } from '../../interfaces/ijuego';
import { JuegoService } from '../juego.service';

@Component({
  selector: 'app-buscar',
  templateUrl: './buscar.component.html',
  styleUrl: './buscar.component.css',
})
export class BuscarComponent {
  juegos: IJuego[] = [];
  buscar: string = "";
  histbus: string = "";

  constructor(private juegoServ: JuegoService) {
    this.cargarJuegos();
  }

  cargarJuegos() {
    this.juegoServ.getList().subscribe((juegos: IJuego[]) => {
      this.juegos = juegos;
    })
  }

  onKey(event: KeyboardEvent) {
    this.buscar = (event.target as HTMLInputElement).value;
    if (this.histbus.length > this.buscar.length) {
      this.cargarJuegos()
    } else {
      this.juegos = this.juegos.filter(j => j.nombre.toUpperCase().includes(this.buscar.toUpperCase()))
    }
    this.histbus = (event.target as HTMLInputElement).value;
  }

  filtrarCategoria(categoria: number){
    this.juegoServ.getListCategorias(categoria).subscribe((juegos: IJuego[]) => {
      this.juegos = juegos;
    })
  }
}
