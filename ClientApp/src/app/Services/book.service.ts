import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class BookService {

  _baseURL:string = "api/Books";
  
  constructor() { }

  getAllBooks(){
    return this.http.get<Book[]>(this._baseURL+"/GetBooks");
  }
}
