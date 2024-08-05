import React from 'react';
import { Carousel } from 'react-bootstrap';
import 'bootstrap/dist/css/bootstrap.min.css';

const HomePage = () => {
  return (
    <div style={{ backgroundColor: '#f9ecd2', minHeight: '100vh', padding: '20px', display: 'flex', flexDirection: 'column', alignItems: 'center', justifyContent: 'center' }}>
      <h2>Welcome to Bridal Gowns App</h2>
      <Carousel>
        <Carousel.Item>
          <img
            className="d-block w-100"
            src="./images/hp1.png"
            alt="1"
          />
        </Carousel.Item>
        <Carousel.Item>
          <img
            className="d-block w-100"
            src="./images/hp2.png"
            alt="2"
          />
        </Carousel.Item>
        <Carousel.Item>
          <img
            className="d-block w-100"
            src="./images/hp3.png"
            alt="3"
          />
        </Carousel.Item>
      </Carousel>
    </div>
  );
};

export default HomePage;
