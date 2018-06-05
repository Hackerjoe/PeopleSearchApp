import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'fetchdata',
    templateUrl: './fetchdata.component.html'
})
export class FetchDataComponent {
    public people: Person[];

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        http.get(baseUrl + 'allpeople').subscribe(result => {
            this.people = result.json() as Person[];
            if (this.people[0] == undefined) {
                console.error("NOPE");
            }
        }, error => console.error(error));
    }
}

interface Person {
    personID: number;
    name: string;
    age: number;
    address: string;
    interest: string;
}
