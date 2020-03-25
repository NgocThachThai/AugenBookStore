import { ApiRouter } from '../config/api-router'
import axios from 'axios'

export const getPackages = () => {
    return axios.get(ApiRouter.VENDOR_DELIVERIES);
}