import { useEffect, useState } from "react";
import Card from 'react-bootstrap/Card';
const Order = () => {
  const [orders, setUsers] = useState([]);
  useEffect(() => {
    fetch('http://localhost:5124/api/Orders')
      .then((res) => {
        return res.json();
      })
      .then((data) => {
        console.log(data);
        setUsers(data);
      });
  }, []);

  const txt = { "textAlign": "center" }
  return (
    <center>
      <table class="table table-striped" style={{ "width": "50rem", "alignContent": "center", "color": "white" }}>
        <tr>
          <th style={txt}>Order Number</th>
          <th style={txt}>Description</th>
          <th style={txt}>Price</th>
          <th style={txt}>Image</th>
        </tr>
        {gowns.map((gown) => (
          <tr>
            <td style={txt}>{gown.orderNumber}</td>
            <td style={txt}>{gown.date}</td>
            <td style={txt}>{gown.weddingDate}</td>
            <td style={txt}>{gown.imageCode}</td>
          </tr>
        ))}
      </table>
    </center>
  );
};
export default Order;