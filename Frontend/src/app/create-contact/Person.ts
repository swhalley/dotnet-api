import { Address } from './Address';

export class Person {
    name: string;
    birthdate: Date;
    address: Address;

    constructor(){
        this.address = new Address();
    }
}
