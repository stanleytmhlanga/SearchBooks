import { Injectable } from '@angular/core';
import {HttpClient,HttpHeaders,HttpParams} from '@angular/common/http'
import { Observable } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class SearchApiService {

  constructor(private httpClient:HttpClient){}
  apiUrl = 'https://localhost:44368/api/Search/SearchBookByTitle?title=six';


  getBooks(): Observable<any>
  {
    var results= this.httpClient.get(this.apiUrl);
    console.log(results)
    return results;
  }
  getBooksByTitle(title:string): Observable<any>
  {
    var Url = 'https://localhost:44368/api/Search/SearchBookByTitle?title='+title;
    var results= this.httpClient.get(Url);
    console.warn("getBooksByTitle",results)
    return results;
  }

}
