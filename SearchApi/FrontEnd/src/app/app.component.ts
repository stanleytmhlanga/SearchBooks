import { Component } from '@angular/core';
import { Observable } from 'SearchBooks/node_modules/rxjs';
import {Book} from 'src/app/interfaces/book'
import {SearchApiService} from './search-api.service'
import { catchError, map, tap } from 'rxjs/operators';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent {
  title = 'SearchBooks';

  public error:any;
  books$!: Observable<Book[]>;
  public books: Array<Book> = [];
  constructor(private api:SearchApiService ) {}

  getBooks(){
    this.api.getBooks().subscribe((data)=>{
      this.books = data;
    })
  }

  OnSearchClick(search:string)
  {
    this.api.getBooksByTitle(search).subscribe((data)=>{
      this.books = data;
    })
}
  ngOnInit() {
    this.getBooks();
  }

}
