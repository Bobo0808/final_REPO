import { apiHelper } from './helpers'

export default {
    getPayment() {
        return apiHelper.get(`/payment`)
    }
}