import { User } from "./user";

export class Account extends User{
    companyName! : string;
    apiUrl!: string;
    apiKey!: string;
}