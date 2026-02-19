import { HttpClient } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { API_URL } from '../../app.config';
import { Observable } from 'rxjs';
import { ResponseAPI } from '../interfaces/response-api';

@Injectable({
  providedIn: 'root',
})
export class RolService {
  private http = inject(HttpClient);
  private apiUrl = inject(API_URL);

  private apiUrlInterface = this.apiUrl + 'Rol/';

  lista(): Observable<ResponseAPI> {
    return this.http.get<ResponseAPI>(`${this.apiUrlInterface}Lista`);
  }
}
