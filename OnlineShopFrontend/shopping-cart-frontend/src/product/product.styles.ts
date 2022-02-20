import styled from "styled-components";

export const Wrapper = styled.div`
  display: flex;
  justify-content: space-between;
  align-items: center;
  flex-direction: column;
  width: 80%;
  border: 1px solid lightblue;
  border-radius: 20px;
  height: 100%;

  button {
    display: block;
    border-radius: 20px 20px 20px 20px;
    color: #8d99ae;
    background-color: #e5e5e5;
    margin-bottom: 20px;
    margin-top: 20px;
  }

  img {
    margin-top: 20px;
    max-height: 150px;
    max-width: 200px;
    object-fit: cover;
    border-radius: 20px 20px 0 0;
  }

  div {
    display: flex;
    align-items: center;
    justify-content: center;
    flex-direction: column;
    font-family: Arial, Helvetica, sans-serif;
    padding: item;
    height: 100%;
    align-items: center;
  }

  p {
    align-items: center;
    font-size: 20px;
    margin-left: 50px;
    margin-right: 50px;
    margin-top: 50px;
    margin-bottom: 10px;
  }

  .price {
    margin-top: 10px;
  }
`;
