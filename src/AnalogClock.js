import React, { useState, useEffect } from 'react';

const AnalogClock = () => {
  const [time, setTime] = useState(new Date());

  useEffect(() => {
    const timerId = setInterval(() => {
      setTime(new Date());
    }, 1000);

    return () => {
      clearInterval(timerId);
    };
  }, []);

  const seconds = time.getSeconds();
  const minutes = time.getMinutes();
  const hours = time.getHours();

  const secondHandRotation = (seconds / 60) * 360;
  const minuteHandRotation = (minutes / 60) * 360 + (seconds / 60) * 6;
  const hourHandRotation = (hours / 12) * 360 + (minutes / 60) * 30;

  return (
    <div className="clock">
      <div className="hand hour" style={{ transform: `rotate(${hourHandRotation}deg)` }}></div>
      <div className="hand minute" style={{ transform: `rotate(${minuteHandRotation}deg)` }}></div>
      <div className="hand second" style={{ transform: `rotate(${secondHandRotation}deg)` }}></div>
      <div className="point"></div>
    </div>
  );
};

export default AnalogClock;
