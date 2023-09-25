export interface IWeatherForecast {
     current: ICurrent;
     forecast: IForecast;
}

export interface IForecast {
    forecastDay: IForecastDay[];
}

export interface IForecastDay {
    date: Date
    day: IDay;
    hour: IHour[];
}
export interface IDay {
    avgtemp_c: number;
    avgvis_km: number;
}

export interface IHour {
    time: string;
    temp_c: number;
    condition: ICondition;
}

export interface ICurrent {
    condition: ICondition;
    temp_C: number;
}

export interface ICondition {
    text: string;
    icon: string;
}