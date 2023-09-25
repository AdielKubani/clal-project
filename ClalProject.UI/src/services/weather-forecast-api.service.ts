import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { IForecast, IWeatherForecast } from 'src/models/weather-forecast.interface';

@Injectable({
  providedIn: 'root'
})
export class WeatherForecastApiService {

  private url = "ThreeDayWeatherForecast";

  constructor(private http: HttpClient) { }

  private headers = new HttpHeaders({
    'Content-Type': 'application/json',
    'Access-Control-Allow-Origin': '*'
  });

  public getWeatherForecast(city: string): Observable<IForecast> {
    const requestOptions = {
      headers: this.headers
    };
  
    return this.http.get<IForecast>(`${environment.apiUrl}/${this.url}/${city}`, requestOptions );
  }
}
