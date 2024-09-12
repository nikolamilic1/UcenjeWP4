import { Await } from "react-router-dom"
import { HttpService } from "./HttpService"


async function get() {
    return await HttpService.get('/Smjer')
    .then((odgovor)=>{
        // console.table(odgovor.data);
        return odgovor.data;
    })
    .catch((e)=>{console.error(e)})
}

export default{
    get
}