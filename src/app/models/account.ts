import { User } from "./user";

export class Account extends User{
    companyName! : string;
    apiUrl!: string;
    apiKey!: string;

    constructor(email : string, password:string,companyName : string, apiUrl : string, apiKey : string){
        super(email,password);
        this.companyName = companyName;
        this.apiUrl = apiUrl;
        this.apiKey = apiKey;
    }

}