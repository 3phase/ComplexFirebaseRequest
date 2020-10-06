import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class UsersService {

  private baseUrl: string;
  private httpHeaders = new HttpHeaders({
    Accept: 'application/json',
    'Content-Type': 'application/json'
  });

  constructor(
    public http: HttpClient,
    @Inject('BASE_URL') baseUrl: string
  ) {
    this.baseUrl = baseUrl;
  }

  public fetchData() {
    return this.http.get(
      this.baseUrl + 'api/Users/all-users',
      { headers: this.httpHeaders }
    ).pipe(
      map((result: any[]) => result.map(x => x.uid))
    );
  }

}
