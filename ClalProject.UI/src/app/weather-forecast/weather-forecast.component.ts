import { Component } from '@angular/core';
import { IForecast } from 'src/models/weather-forecast.interface';
import { WeatherForecastApiService } from 'src/services/weather-forecast-api.service';

@Component({
  selector: 'app-weather-forecast',
  templateUrl: './weather-forecast.component.html',
  styleUrls: ['./weather-forecast.component.css']
})
export class WeatherForecastComponent {

  constructor(private weatherForecastApiService: WeatherForecastApiService) { }

  public city: string = "";
  public forecast: IForecast = {} as IForecast;

  onCitySubmit() {
    this.weatherForecastApiService.getWeatherForecast(this.city).subscribe({
      next: (result: IForecast) => (this.forecast = result),
      error: (error) => alert(`City: ${this.city} not found`)
    });
  }
}
