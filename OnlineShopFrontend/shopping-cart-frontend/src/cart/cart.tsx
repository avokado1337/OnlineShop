import { ProductType } from "../App";
import { CartItemProduct } from "../App";
import { Wrapper } from "./cart.styled";
import { useQuery } from "react-query";

type Props = {
  cartItem: CartItemProduct;
};

const getCart = async (): Promise<CartItemProduct> =>
  await (
    await fetch("http://localhost:11016/api/ShoppingCart?cartId=1")
  ).json();

const Cart: React.FC<Props> = ({ cartItem }) => <p>{cartItem.cartId}</p>;

export default Cart;
