import { Component, Input } from '@angular/core';
import { IForecastDay } from 'src/models/weather-forecast.interface';

@Component({
  selector: 'app-forecast-day-card',
  templateUrl: './forecast-day-card.component.html',
  styleUrls: ['./forecast-day-card.component.css']
})
export class ForecastDayCardComponent {
   @Input() forecast: IForecastDay = {} as IForecastDay;
}
