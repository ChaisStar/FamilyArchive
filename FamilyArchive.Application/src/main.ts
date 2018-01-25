import { AppModule } from './app/appModule';
import { platformBrowserDynamic} from '@angular/platform-browser-dynamic';

const platform = platformBrowserDynamic();
platform.bootstrapModule(AppModule);