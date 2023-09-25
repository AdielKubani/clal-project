import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { WeatherForecastComponent } from './weather-forecast/weather-forecast.component';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { ForecastDayCardComponent } from './weather-forecast/forecast-day-card/forecast-day-card.component';
import { MatCardModule } from '@angular/material/card';
import { MatIconModule } from '@angular/material/icon';
import { ForecastHourCardComponent } from './weather-forecast/forecast-day-card/forecast-hour-card/forecast-hour-card.component';

@NgModule({
  declarations: [
    AppComponent,
    WeatherForecastComponent,
    ForecastDayCardComponent,
    ForecastHourCardComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    MatCardModule,
    MatIconModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
