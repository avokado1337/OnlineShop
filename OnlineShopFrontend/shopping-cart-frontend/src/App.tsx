import { useState } from "react";
import { useQuery } from "react-query";
import Drawer from "@material-ui/core/Drawer";
import CircularProgress from "@material-ui/core/CircularProgress";
import Grid from "@material-ui/core/Grid";
import AddShoppingCartIcon from "@material-ui/icons/AddShoppingCart";
import Badge from "@material-ui/core/Badge";
import { Wrapper, StyledButton } from "./App.styles";
import Product from "./product/product";
import * as React from "react";
import Cart from "./cart/cart";

export type ProductType = {
  productId: number;
  productName: string;
  productPrice: number;
  productPicture: string;
  amount: number;
};

export type CartItemProduct = {
  cartItemId: number;
  cartId: number;
  product: ProductType[];
  qnt: number;
};

const getProducts = async (): Promise<ProductType[]> =>
  await (await fetch("http://localhost:11016/api/Products")).json();

const getCart = async (): Promise<CartItemProduct> =>
  await (
    await fetch("http://localhost:11016/api/ShoppingCart?cartId=1")
  ).json();

const App = () => {
  const [cartOpen, setCartOpen] = useState(false);
  const [cartItems, setCartItems] = useState([] as ProductType[]);
  const { data, isLoading, error } = useQuery<ProductType[]>(
    "products",
    getProducts
  );

  const handleAddToCart = () => null;
  const getTotalItems = (products: ProductType[]) => null;

  console.log(data);

  if (isLoading) return <CircularProgress />;

  if (error) return <div>Something went wrong</div>;

  return (
    <Wrapper>
      <Drawer anchor="right" open={cartOpen} onClose={() => setCartOpen(false)}>
        Cart here
      </Drawer>
      <StyledButton onClick={() => setCartOpen(true)}>
        <Badge badgeContent={getTotalItems(cartItems)} color="error">
          <AddShoppingCartIcon />
        </Badge>
      </StyledButton>

      <Grid container spacing={3}>
        {data?.map((product) => (
          <Grid item key={product.productId} xs={12} sm={4}>
            <Product product={product} />
          </Grid>
        ))}
      </Grid>
    </Wrapper>
  );
};

export default App;
