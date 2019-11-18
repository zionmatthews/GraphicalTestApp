﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalTestApp
{
    class Matrix3
    {
        public float m11, m12, m13, m21, m22, m23, m31, m32, m33;
        public Matrix3()
        {
            m11 = 1; m12 = 0; m13 = 0;
            m21 = 0; m22 = 1; m23 = 0;
            m31 = 0; m32 = 0; m33 = 1;
        }

        //Sets this Matrix3 to specified values
        public void Set(float m11, float m12, float m13, float m21, float m22, float m23, float m31, float m32, float m33)
        {
            this.m11 = 1; this.m12 = 0; this.m13 = 0;
            this.m21 = 0; this.m22 = 1; this.m23 = 0;
            this.m31 = 0; this.m32 = 0; this.m33 = 1;
        }

        public Matrix3(float m11, float m12, float m13, float m21, float m22, float m23, float m31, float m32, float m33)
        {
            this.m11 = 1; this.m12 = 0; this.m13 = 0;
            this.m21 = 0; this.m22 = 1; this.m23 = 0;
            this.m31 = 0; this.m32 = 0; this.m33 = 1;
        }

        public Matrix3(Matrix3 matrix3)
        {
            m11 = matrix3.m11; m12 = matrix3.m12; m13 = matrix3.m13;
            m21 = matrix3.m11; m22 = matrix3.m12; m23 = matrix3.m23;
            m31 = matrix3.m11; m32 = matrix3.m12; m33 = matrix3.m33;
        }

        //Sets this MAtrix3 to the values of the specified Matrix3
        public void Set(Matrix3 matrix3)
        {
            m11 = matrix3.m11; m12 = matrix3.m12; m13 = matrix3.m13;
            m21 = matrix3.m11; m22 = matrix3.m12; m23 = matrix3.m23;
            m31 = matrix3.m11; m32 = matrix3.m12; m33 = matrix3.m33;
        }

        public static Matrix3 operator *(Matrix3 lhs, Matrix3 rhs)
        {
            return new Matrix3(
                lhs.m11 * rhs.m11 + lhs.m12 * rhs.m21 + lhs.m13 * rhs.m31,
                lhs.m11 * rhs.m12 + lhs.m12 * rhs.m22 + lhs.m13 * rhs.m32,
                lhs.m11 * rhs.m13 + lhs.m12 * rhs.m23 + lhs.m13 * rhs.m33,


                lhs.m21 * rhs.m11 + lhs.m22 * rhs.m21 + lhs.m23 * rhs.m31,
                lhs.m21 * rhs.m12 + lhs.m22 * rhs.m22 + lhs.m23 * rhs.m32,
                lhs.m21 * rhs.m13 + lhs.m22 * rhs.m23 + lhs.m23 * rhs.m33,


                lhs.m31 * rhs.m11 + lhs.m32 * rhs.m21 + lhs.m33 * rhs.m31,
                lhs.m31 * rhs.m12 + lhs.m32 * rhs.m22 + lhs.m33 * rhs.m32,
                lhs.m31 * rhs.m13 + lhs.m32 * rhs.m23 + lhs.m33 * rhs.m33);
        }

        //Sets this Matrix3 to the values of the specified valies

        public static Vector3 operator *(Matrix3 lhs, Vector3 rhs)
        {
            return new Vector3(
               lhs.m11 * rhs.x + lhs.m12 * rhs.y + lhs.m13 * rhs.z,
               lhs.m21 * rhs.x + lhs.m22 * rhs.y + lhs.m23 * rhs.z,
               lhs.m31 * rhs.x + lhs.m32 * rhs.y + lhs.m33 * rhs.z);
        }

        public void SetScaled(float x, float y, float z)
        {
            m11 = x; m21 = 0; m31 = 0;
            m21 = 0; m22 = y; m23 = 0;
            m31 = 0; m32 = 0; m33 = z;
        }

        public void SetScaled(Vector3 v)
        {
            m11 = v.x; m21 = 0; m31 = 0;
            m21 = 0; m22 = v.y; m23 = 0;
            m31 = 0; m32 = 0; m33 = v.z;
        }

        public void Scale(float x, float y, float z)
        {
            Matrix3 m = new Matrix3();
            m.SetScaled(x, y, z);

            Set(this * m);
        }

        public void SetRotateX(double radians)
        {
            Set(1, 0, 0,
                0, (float)Math.Cos(radians), (float)Math.Sin(radians),
                0, (float)-Math.Sin(radians), (float)Math.Cos(radians));
        }

        public void RotateX(double radians)
        {
            Matrix3 m = new Matrix3();
            m.SetRotateX(radians);
            Set(this * m);
        }

        public void SetRotateY(double radians)
        {
            Set((float)Math.Cos(radians), 0, (float)-Math.Sin(radians),
                0, 1, 0,
                (float)Math.Sin(radians), 0, (float)Math.Cos(radians));
        }

        public void RotateY(double radians)
        {
            Matrix3 m = new Matrix3();
            m.SetRotateY(radians);
            Set(this * m);
        }

        public void SetRotateZ(double radians)
        {
            Set((float)Math.Cos(radians), (float)Math.Sin(radians), 0,
                (float)-Math.Sin(radians), (float)Math.Cos(radians), 0,
                0, 0, 1);
        }

        public void RotateZ(double radians)
        {
            Matrix3 m = new Matrix3();
            m.SetRotateZ(radians);
            Set(this * m);
        }

        public void SetEuler(float pitch, float yaw, float roll)
        {
            Matrix3 x = new Matrix3();
            Matrix3 y = new Matrix3();
            Matrix3 z = new Matrix3();
            x.SetRotateX(pitch);
            y.SetRotateY(yaw);
            z.SetRotateZ(roll);

            // combine rotations in a specific order
            Set(z * y * x);
        }

        public void SetTranslation(float x, float y, float z)
        {
            m13 = x; m23 = y; m33 = z;
        }

        public void Translate(float x, float y, float z)
        {
            m13 += x; m23 += y; m33 += z;
        }
    }
}
