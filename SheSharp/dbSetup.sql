CREATE TABLE IF NOT EXISTS accounts(
  id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name varchar(255) COMMENT 'User Name',
  email varchar(255) COMMENT 'User Email',
  picture varchar(255) COMMENT 'User Picture'
) default charset utf8 COMMENT '';

CREATE TABLE IF NOT EXISTS groom(
  id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
  name VARCHAR(255),
  startTime VARCHAR(255) DEFAULT "start time",
  endTime VARCHAR(255) DEFAULT "end time",
  groomLocation VARCHAR(255) DEFAULT "Untitled",
  size INT NOT NULL,
  price FLOAT NOT NULL,
  tip INT NOT NULL, 
  creatorId VARCHAR(255) NOT NULL,
  breed VARCHAR(255) DEFAULT "Untitled",
  services VARCHAR(255) DEFAULT "Untitled",

  FOREIGN KEY (creatorId)
    REFERENCES accounts(id)
    ON DELETE CASCADE

) default charset utf8;