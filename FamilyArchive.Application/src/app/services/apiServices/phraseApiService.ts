import { Injectable } from "@angular/core";
import { HttpService } from "../httpService";
import { Phrase } from "../../models/Phrase";
import { CreatePhraseDto } from "../../models/Dtos/CreatePhraseDto";

@Injectable()
export class PhraseApiService {
    constructor(private httpService: HttpService) { }

    getPhrases = (): Promise<Phrase[]> => this.httpService.getDataAsync<Phrase[]>("api/phrase");
    addPhrase = (from: string, to: string, text: string): Promise<void> => 
        this.httpService.postDataAsync<CreatePhraseDto, void>("api/phrase", new CreatePhraseDto(from, to, text));
    deletePhrase = (guid:string): Promise<void> => this.httpService.deleteDataAsync<void>(`api/phrase/${guid}`);
}