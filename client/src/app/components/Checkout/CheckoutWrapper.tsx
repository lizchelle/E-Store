import { Elements } from "@stripe/react-stripe-js";
import { loadStripe } from "@stripe/stripe-js";
import { useEffect, useState } from "react";
import { useAppDispatch } from "../../ store/configureStore";
import { setBasket } from "../../../features/basket/basketSlice";
import CheckoutPage from "../../../features/checkout/CheckoutPage";
import agent from "../../api/agent";
import LoadingComponent from "../../layout/LoadingComponent";

const stripePromise = loadStripe('pk_test_51L2elsH43lSbuExJytFM3D7wsO5mWjr4t87Y6UUWHd1X2YwrkAK4yaosjdHyG0SSzsWgQz2758QuRJEio00X6Uht00RrjzmCr6')

export default function CheckoutWrapper() {
    const dispatch = useAppDispatch();
    const [loading, setLoading] = useState(true);

    useEffect(() => {

        agent.Payments.createPaymentIntent()
            .then(basket => dispatch(setBasket(basket)))
            .catch(error => console.log(error))
            .finally(() => setLoading(false))
    }, [dispatch]);

    if (loading) return <LoadingComponent message='Loading checkout...'/>
    
    return(
        <Elements stripe={stripePromise}>
            <CheckoutPage/>
        </Elements>
    )
}