// import { Injectable } from '@angular/core';
// import { Observable } from 'rxjs';
// import { IForecast, IWeatherForecast } from 'src/models/weather-forecast.interface';
// import { WeatherForecastApiService } from './weather-forecast-api.service';

// @Injectable({
//   providedIn: 'root'
// })
// export class WeatherForecastService {
//   constructor(private weatherForecastApiService: WeatherForecastApiService) { }

//   public getWeatherForecast(city: string): Observable<IForecast> {
//     let forecast: IWeatherForecast;
//     return this.weatherForecastApiService.getWeatherForecast(city).subscribe(result => forecast = result);
//   }
// }
