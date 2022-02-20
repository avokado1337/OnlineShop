import styled from "styled-components";
import IconButton from "@material-ui/core/button";

export const Wrapper = styled.div`
  background-color: #edf2f4;
  margin: 40px;
`;

export const StyledButton = styled(IconButton)`
  position: fixed;
  z-index: 100;
  right: 5px;
  top: 20px;
`;
