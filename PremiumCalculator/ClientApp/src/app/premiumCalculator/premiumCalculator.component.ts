import { Component,  Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-premiumCalculator',
  templateUrl: './premiumCalculator.component.html',
})

export class PremiumCalculatorComponent {
  private _httpClient: HttpClient;
  private _baseUrl: string;
  private name: string;
  private dateOfBirth: Date;
  private age: number;
  private deathCoverAmount: number;
  private occupation: string;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this._httpClient = http;
    this._baseUrl = baseUrl;

  }

  getMonthlyPremium() {
    var input : MemberDetails = {
      name: this.name,
      age: Number(this.age),
      dateOfBirth: this.dateOfBirth,
      deathCoverAmount: Number(this.deathCoverAmount),
      occupation: this.occupation
    }
    this._httpClient.post<number>(this._baseUrl + 'PremiumCalculator', input)
    .subscribe(result => { },
       error => console.error(error));
  }

}

interface MemberDetails {
  name: string,
  age: number;
  dateOfBirth: Date;
  occupation: string;
  deathCoverAmount: number;
}