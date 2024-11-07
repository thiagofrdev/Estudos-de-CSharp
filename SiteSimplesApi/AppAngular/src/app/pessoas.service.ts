import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Pessoa } from './Pessoa';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json'
  })
};

@Injectable({
  providedIn: 'root'
})
export class PessoasService {
  url = 'https://localhost:5289/api/pessoas';

  constructor(private http: HttpClient) { }

  GetAll(): Observable<Pessoa[]>{
    return this.http.get<Pessoa[]>(this.url);
  }

  GetById(pessoaId: number): Observable<Pessoa>{
    const apiUrl = `${this.url}/${pessoaId}`;
    return this.http.get<Pessoa>(apiUrl);
  }

  SavePeople(pessoa: Pessoa): Observable<any>{
    return this.http.post<Pessoa>(this.url, pessoa, httpOptions);
  }

  UpdatePeople(pessoa: Pessoa): Observable<any>{
    return this.http.put<Pessoa>(this.url, pessoa, httpOptions);
  }

  DeletePessoa(pessoaId: number): Observable<any>{
    const apiUrl = `${this.url}/${pessoaId}`;
    return this.http.delete<Pessoa>(apiUrl);
  }
}
