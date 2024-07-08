import { Injectable } from '@angular/core';
import { IJuego } from "../interfaces/ijuego";
import { HttpClient } from '@angular/common/http';
import { environment } from '../../environments/environment.development';
import { Observable } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class JuegoService {
  private _endpoint: string = environment.endPoint;
  private apiUrl: string = this._endpoint + "/";

  juegos: IJuego[] = [];

  constructor(private _http: HttpClient) {
  }

  getList(): Observable<IJuego[]> {
    let list = this._http.get<IJuego[]>('https://localhost:7045/getProductos');
    return list;
  }

  getListCategorias(categoria: number): Observable<IJuego[]> {
    let list = this._http.get<IJuego[]>(`https://localhost:7045/getProductosCategoria?Categoria=${categoria}`);
    return list;
  }

}
