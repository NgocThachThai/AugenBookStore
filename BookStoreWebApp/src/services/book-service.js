import { ApiRouter } from '../config/api-router'
import axios from 'axios'

export const getBooks = (searchText) => {
    return axios.get(`${ApiRouter.BOOKSGOOGLEAPI}/volumes?q=${searchText?searchText:'search'}`);
}
export const buyBook = (deliveryInfor) => {
    return axios.post(ApiRouter.BOOKS, deliveryInfor);
}