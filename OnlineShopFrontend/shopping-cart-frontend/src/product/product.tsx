import Button from "@material-ui/core/Button";
import { ProductType } from "../App";
import { Wrapper } from "./product.styles";

type Props = {
  product: ProductType;
};

const Product: React.FC<Props> = ({ product }) => (
  <Wrapper>
    <img src={product.productPicture} alt={product.productName} />
    <div>
      <p>{product.productName}</p>
      <p className="price">${product.productPrice}</p>
    </div>
    <Button>Add to cart</Button>
  </Wrapper>
);

export default Product;
