import { Component, OnInit } from "@angular/core";
import { Phrase } from "../../models/Phrase";
import { PhraseApiService } from "../../services/apiServices/phraseApiService";

@Component({
    selector: "my-app",
    templateUrl: "./phraseComponent.html",
    providers: [PhraseApiService]
})
export class AppComponent implements OnInit {
    ngOnInit():void { this.getData(); }

    phrases: Phrase[] = [];

    constructor(private phraseApiService: PhraseApiService) { }

    private getData = async (): Promise<void> => {
        this.phrases = await this.phraseApiService.getPhrases();
    }

    addItem = async (): Promise<void> => {
        await this.phraseApiService.addPhrase("1", "2", "3");
        await this.getData();
    }

    deleteItem = async (id: string): Promise<void> => {
        await this.phraseApiService.deletePhrase(id);
        await this.getData();
    }
}
