import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import {MatButtonModule} from '@angular/material/button'
import { KeyStoreAppItems } from './KeyStoreAppItems';
import { HomeComponent } from './components/home/home.component';
import { NavigationComponent } from "./components/navigation/navigation.component";

@Component({
    selector: 'app-root',
    standalone: true,
    templateUrl: './app.component.html',
    styleUrl: './app.component.css',
    imports: [RouterOutlet, MatButtonModule, HomeComponent, NavigationComponent]
})
export class AppComponent {
  Title(Title: any) {
    throw new Error('Method not implemented.');
  }
}