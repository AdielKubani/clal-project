import { Component, Input } from '@angular/core';
import { IHour } from 'src/models/weather-forecast.interface';

@Component({
  selector: 'app-forecast-hour-card',
  templateUrl: './forecast-hour-card.component.html',
  styleUrls: ['./forecast-hour-card.component.css']
})
export class ForecastHourCardComponent {
  @Input() hour: IHour = {} as IHour;
}
