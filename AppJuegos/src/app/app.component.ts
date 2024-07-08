import { Component } from '@angular/core';
import { RouterLink, RouterOutlet } from '@angular/router';
import { FeaturesModule } from './features/features.module';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, RouterLink, FeaturesModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'AppJuegos';
}
