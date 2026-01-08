import { HttpClient } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';
import { API_URL } from '../app.config';
import { Observable } from 'rxjs';
import { ResponseAPI } from '../Interfaces/response-api';
import { Usuario } from '../Interfaces/usuario';

@Injectable({
  providedIn: 'root',
})
export class UsuarioService {
  private http = inject(HttpClient);
  private apiUrl = inject(API_URL);

  private apiUrlInterface = this.apiUrl + 'Usuario/';

  lista(): Observable<ResponseAPI> {
    return this.http.get<ResponseAPI>(`${this.apiUrlInterface}Lista`);
  }

  crear(request: Usuario): Observable<ResponseAPI>{
    return this.http.post<ResponseAPI>(`${this.apiUrlInterface}Crear`, request);
  }

  editar(request: Usuario): Observable<ResponseAPI>{
    return this.http.put<ResponseAPI>(`${this.apiUrlInterface}Editar`, request);
  }

  desactivar(id: number): Observable<ResponseAPI>{
    return this.http.put<ResponseAPI>(`${this.apiUrlInterface}Desactivar/${id}`, {});
  }
}