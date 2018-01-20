import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Phrase, CreatePhraseDto } from './Phrase';

@Injectable()
export class HttpService {

    constructor(private http: HttpClient) { }

    getData() {
        return this.http.get("api/phrase");
    }

    postData(phrase: CreatePhraseDto) {
        return this.http.post("api/phrase", phrase);
    }
}