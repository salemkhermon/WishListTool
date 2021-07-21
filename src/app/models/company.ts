
export class Company{

    name !: string;
    email !: string;
    apiUrl!: string;
    apiKey!: string;
    password !: string;

    constructor(email : string, password:string,companyName : string, apiUrl : string, apiKey : string){
        this.email = email;
        this.password = password;
        this.name = companyName;
        this.apiUrl = apiUrl;
        this.apiKey = apiKey;
    } 

}