import { Component } from "@angular/core";
import { Phrase, CreatePhraseDto } from "./Phrase";
import { HttpService } from "./http.Service";

@Component({
    selector: "my-app",
    templateUrl: "./app.component.html",
    providers: [HttpService]
})
export class AppComponent {
    phrases: Phrase[] = []

    constructor(private httpService: HttpService) {
        this.getData();
        console.log(httpService.getData());
    }

    private getData = ():void =>{
        this.httpService.getData().subscribe((data: Phrase[]) => this.phrases = data);
    }

    addItem = (): void => { 
        this.httpService.postData(new CreatePhraseDto("1", "2", "3")).subscribe(() => this.getData); 
    }
};