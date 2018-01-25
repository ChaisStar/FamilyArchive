import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Phrase } from '../models/Phrase';
import { CreatePhraseDto } from '../models/Dtos/CreatePhraseDto';

@Injectable()
export class HttpService {
    constructor(private http: HttpClient) { }

    getDataAsync = <T>(url: string): Promise<T> => {
        return new Promise<T>((resolve, reject) => {
            try {
                this.http.get(url).subscribe(data => {
                    resolve(data as T);
                })
            } catch (error) {
                reject(error);
            }
        })
    }

    postDataAsync = <TRequest, TResponse>(url: string, request:TRequest): Promise<TResponse> => {
        return new Promise<TResponse>((resolve, reject) => {
            try {
                this.http.post(url, request).subscribe(data => {
                    resolve(data as TResponse);
                })
            } catch (error) {
                reject(error);
            }
        })
    }

    putDataAsync = <TRequest, TResponse>(url: string, request:TRequest): Promise<TResponse> => {
        return new Promise<TResponse>((resolve, reject) => {
            try {
                this.http.put(url, request).subscribe(data => {
                    resolve(data as TResponse);
                })
            } catch (error) {
                reject(error);
            }
        })
    }

    deleteDataAsync = <T>(url: string): Promise<T> => {
        return new Promise<T>((resolve, reject) => {
            try {
                this.http.delete(url).subscribe(data => {
                    resolve(data as T);
                })
            } catch (error) {
                reject(error);
            }
        })
    }
}