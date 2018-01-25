import { NgModule } from "@angular/core";
import { BrowserModule } from "@angular/platform-browser";
import { FormsModule } from "@angular/forms";
import { AppComponent } from "./components/phraseComponent/phraseComponent";
import { HttpClientModule } from "@angular/common/http"
import { HttpService } from "./services/httpService";

@NgModule({
    imports: [BrowserModule, FormsModule, HttpClientModule],
    declarations: [AppComponent],
    providers: [HttpService],
    bootstrap: [AppComponent]
})
export class AppModule {

};