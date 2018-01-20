export class Phrase {
    from: string;
    to: string;
    text: string;
    guid: string;
    created: Date;
    updated: Date;
}

export class CreatePhraseDto{
    constructor (public from: string, public to: string, public text:string){}
}