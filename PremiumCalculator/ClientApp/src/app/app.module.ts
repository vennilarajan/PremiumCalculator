import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { MatExpansionModule, 
         MatInputModule, 
         MatButtonModule, 
         MatButtonToggleModule, 
         MatCardModule,
         MatDatepickerModule,
         MatNativeDateModule} from '@angular/material';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { PremiumCalculatorComponent } from './premiumCalculator/premiumCalculator.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

@NgModule({
  exports: [
    MatExpansionModule, 
    MatInputModule, 
    MatButtonModule, 
    MatButtonToggleModule, 
    MatCardModule, 
    MatDatepickerModule,
    MatNativeDateModule,
  ]
})
export class MaterialModule { }

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    PremiumCalculatorComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: PremiumCalculatorComponent, pathMatch: 'full' }
    ]),
    BrowserAnimationsModule,
    MaterialModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
